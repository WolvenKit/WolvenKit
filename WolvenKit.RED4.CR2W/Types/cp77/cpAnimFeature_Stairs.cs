using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpAnimFeature_Stairs : animAnimFeature
	{
		private CBool _onOff;

		[Ordinal(0)] 
		[RED("onOff")] 
		public CBool OnOff
		{
			get => GetProperty(ref _onOff);
			set => SetProperty(ref _onOff, value);
		}

		public cpAnimFeature_Stairs(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
