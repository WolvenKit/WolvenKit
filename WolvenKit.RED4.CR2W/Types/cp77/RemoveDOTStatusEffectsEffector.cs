using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveDOTStatusEffectsEffector : gameEffector
	{
		private entEntityID _ownerEntityID;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetProperty(ref _ownerEntityID);
			set => SetProperty(ref _ownerEntityID, value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		public RemoveDOTStatusEffectsEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
