using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_LadderEnterStyleData : animAnimFeature
	{
		private CInt32 _enterStyle;

		[Ordinal(0)] 
		[RED("enterStyle")] 
		public CInt32 EnterStyle
		{
			get => GetProperty(ref _enterStyle);
			set => SetProperty(ref _enterStyle, value);
		}

		public AnimFeature_LadderEnterStyleData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
