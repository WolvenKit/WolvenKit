using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneTime : CVariable
	{
		private CUInt32 _stu;

		[Ordinal(0)] 
		[RED("stu")] 
		public CUInt32 Stu
		{
			get => GetProperty(ref _stu);
			set => SetProperty(ref _stu, value);
		}

		public scnSceneTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
