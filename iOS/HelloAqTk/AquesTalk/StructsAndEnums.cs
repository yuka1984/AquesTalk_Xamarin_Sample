using System;
using System.Runtime.InteropServices;

namespace AquesTalk
{
	internal static class AquesTalkLib
	{
		// extern unsigned char * AquesTalk_Synthe (const char *koe, int iSpeed, int *pSize);
		[DllImport("__Internal")]
		static extern unsafe byte* AquesTalk_Synthe(sbyte* koe, int iSpeed, int* pSize);

		// extern unsigned char * AquesTalk_Synthe_Utf8 (const char *koeUtf8, int iSpeed, int *pSize);
		[DllImport("__Internal")]
		static extern unsafe byte* AquesTalk_Synthe_Utf8(sbyte* koeUtf8, int iSpeed, int* pSize);

		// extern void AquesTalk_FreeWave (unsigned char *wav);
		[DllImport("__Internal")]
		static extern unsafe void AquesTalk_FreeWave(byte* wav);

		// extern int AquesTalkDa_PlaySync (const char *koe, int iSpeed);
		[DllImport("__Internal")]
		static extern unsafe int AquesTalkDa_PlaySync(sbyte* koe, int iSpeed);

		// extern int AquesTalkDa_PlaySync_Utf8 (const char *koeUtf8, int iSpeed);
		[DllImport("__Internal")]
		internal static extern int AquesTalkDa_PlaySync_Utf8(IntPtr koeUtf8, int iSpeed);

		// extern H_AQTKDA AquesTalkDa_Create ();
		[DllImport("__Internal")]
		internal static extern IntPtr AquesTalkDa_Create();

		// extern void AquesTalkDa_Release (H_AQTKDA hMe);
		[DllImport("__Internal")]
		internal static extern void AquesTalkDa_Release(IntPtr hMe);

		// extern int AquesTalkDa_Play (H_AQTKDA hMe, const char *koe, int iSpeed, NSNotification *notification);
		[DllImport("__Internal")]
		static extern unsafe int AquesTalkDa_Play(void* hMe, sbyte* koe, int iSpeed, IntPtr notification);

		// extern int AquesTalkDa_Play_Utf8 (H_AQTKDA hMe, const char *koeUtf8, int iSpeed, NSNotification *notification);
		[DllImport("__Internal")]
		internal static extern int AquesTalkDa_Play_Utf8(IntPtr hMe, IntPtr koeUtf8, int iSpeed, IntPtr notification);

		// extern void AquesTalkDa_Stop (H_AQTKDA hMe);
		[DllImport("__Internal")]
		internal static extern void AquesTalkDa_Stop(IntPtr hMe);

		// extern int AquesTalkDa_IsPlay (H_AQTKDA hMe);
		[DllImport("__Internal")]
		internal static extern int AquesTalkDa_IsPlay(IntPtr hMe);
	}
}
