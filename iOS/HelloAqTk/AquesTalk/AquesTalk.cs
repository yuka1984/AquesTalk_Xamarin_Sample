using System;
using System.Runtime.InteropServices;

namespace AquesTalk
{
	public class AquesTalk
	{
		private IntPtr ptr = IntPtr.Zero;
		private static Lazy<AquesTalk> laze = new Lazy<AquesTalk>(() => new AquesTalk());

		public static AquesTalk GetInstance => laze.Value;

		private AquesTalk()
		{
		}

		public void Create()
		{
			if (ptr == IntPtr.Zero)
				ptr = AquesTalkLib.AquesTalkDa_Create();
		}

		public void Release()
		{
			AquesTalkLib.AquesTalkDa_Release(ptr);
			ptr = IntPtr.Zero;
		}

		public int Play(string kana, int speed) => Play(kana, speed, IntPtr.Zero);
		public int Play(string kana, int speed, IntPtr notification)
		{
			Create();
			var bKana = System.Text.Encoding.UTF8.GetBytes(kana);
			var pKana = Marshal.AllocHGlobal(bKana.Length);
			try
			{
				Marshal.Copy(bKana, 0, pKana, bKana.Length);
				return AquesTalkLib.AquesTalkDa_Play_Utf8(ptr, pKana, speed, notification);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				Marshal.FreeHGlobal(pKana);
			}
		}

		public void Stop()
		{
			if (AquesTalkLib.AquesTalkDa_IsPlay(ptr) > 0)
			{
				AquesTalkLib.AquesTalkDa_Stop(ptr);
			}
		}
	}
}
