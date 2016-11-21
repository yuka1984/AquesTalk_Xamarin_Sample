package aquestalk;

public class AquesTalk {
	static {
		System.loadLibrary("AquesTalk");
	}
	/**
	 * 音声記号列から音声データを生成します。JNI実装(native修飾子)
	 * <p>発話速度は通常の速度を100として、50 - 300 の間で指定します(単位は%)。</p>
	 * @param kanaText 音声記号列(UTF-8)
	 * @param speed 発話速度(%)
	 * @return wavフォーマットのデータ
	 */
	public synchronized native byte[] syntheWav(String kanaText, int speed);

}
