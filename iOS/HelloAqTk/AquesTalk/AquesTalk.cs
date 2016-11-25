using System;
using System.Runtime.InteropServices;

namespace AquesTalk
{
	public class AquesTalk
	{
		private IntPtr handle = IntPtr.Zero;
		private static Lazy<AquesTalk> laze = new Lazy<AquesTalk>(() => new AquesTalk());
		public static AquesTalk GetInstance => laze.Value;

		private AquesTalk()
		{
		}

		public void Create()
		{
			if (handle == IntPtr.Zero)
				handle = AquesTalkLib.AquesTalkDa_Create();
		}

		public void Release()
		{
			AquesTalkLib.AquesTalkDa_Release(handle);
			handle = IntPtr.Zero;
		}

		public int Play(string kana, int speed) => Play(kana, speed, IntPtr.Zero);
		public int Play(string kana, int speed, IntPtr notification)
		{			
			var bKana = System.Text.Encoding.UTF8.GetBytes(kana);
			var pKana = Marshal.AllocHGlobal(bKana.Length);
			try
			{
				Marshal.Copy(bKana, 0, pKana, bKana.Length);
				return AquesTalkLib.AquesTalkDa_Play_Utf8(handle, pKana, speed, notification);
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
			AquesTalkLib.AquesTalkDa_Stop(handle);
		}
	}
}
