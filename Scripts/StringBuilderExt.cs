using System.Text;
using JetBrains.Annotations;

namespace Kogane
{
	/// <summary>
	/// StringBuilder 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class StringBuilderExt
	{
		/// <summary>
		/// 指定した文字列のコピーと既定の行終端記号を、現在の StringBuilder オブジェクトの末尾に追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static StringBuilder AppendLine<T1>
		(
			this StringBuilder self,
			string             format,
			T1                 arg1
		)
		{
			self.AppendFormat
			(
				format,
				arg1.ToString()
			);
			self.AppendLine();
			return self;
		}

		/// <summary>
		/// 指定した文字列のコピーと既定の行終端記号を、現在の StringBuilder オブジェクトの末尾に追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static StringBuilder AppendLine<T1, T2>
		(
			this StringBuilder self,
			string             format,
			T1                 arg1,
			T2                 arg2
		)
		{
			self.AppendFormat
			(
				format,
				arg1.ToString(),
				arg2.ToString()
			);
			self.AppendLine();
			return self;
		}

		/// <summary>
		/// 指定した文字列のコピーと既定の行終端記号を、現在の StringBuilder オブジェクトの末尾に追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static StringBuilder AppendLine<T1, T2, T3>
		(
			this StringBuilder self,
			string             format,
			T1                 arg1,
			T2                 arg2,
			T3                 arg3
		)
		{
			self.AppendFormat
			(
				format,
				arg1.ToString(),
				arg2.ToString(),
				arg3.ToString()
			);
			self.AppendLine();
			return self;
		}

		/// <summary>
		/// 指定した文字列のコピーと既定の行終端記号を、現在の StringBuilder オブジェクトの末尾に追加します
		/// </summary>
		[StringFormatMethod( "format" )]
		public static StringBuilder AppendLine<T1, T2, T3, T4>
		(
			this StringBuilder self,
			string             format,
			T1                 arg1,
			T2                 arg2,
			T3                 arg3,
			T4                 arg4
		)
		{
			self.AppendFormat
			(
				format,
				arg1.ToString(),
				arg2.ToString(),
				arg3.ToString(),
				arg4.ToString()
			);
			self.AppendLine();
			return self;
		}
	}
}