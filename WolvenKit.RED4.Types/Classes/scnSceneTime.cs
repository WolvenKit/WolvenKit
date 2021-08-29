using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneTime : RedBaseClass
	{
		private CUInt32 _stu;

		[Ordinal(0)] 
		[RED("stu")] 
		public CUInt32 Stu
		{
			get => GetProperty(ref _stu);
			set => SetProperty(ref _stu, value);
		}
	}
}
