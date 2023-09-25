using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MadnessEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("squadMembers")] 
		public CArray<entEntityID> SquadMembers
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<ScriptedPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		public MadnessEffector()
		{
			SquadMembers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
