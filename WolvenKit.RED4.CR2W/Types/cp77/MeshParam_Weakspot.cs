using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeshParam_Weakspot : animAnimFeature
	{
		private CInt32 _hidden;

		[Ordinal(0)] 
		[RED("hidden")] 
		public CInt32 Hidden
		{
			get => GetProperty(ref _hidden);
			set => SetProperty(ref _hidden, value);
		}

		public MeshParam_Weakspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
