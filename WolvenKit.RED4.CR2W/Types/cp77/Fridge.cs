using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Fridge : InteractiveDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;
		private CName _factOnDoorOpened;

		[Ordinal(93)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(94)] 
		[RED("factOnDoorOpened")] 
		public CName FactOnDoorOpened
		{
			get => GetProperty(ref _factOnDoorOpened);
			set => SetProperty(ref _factOnDoorOpened, value);
		}

		public Fridge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
