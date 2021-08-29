using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMountEventOptions : IScriptable
	{
		private CBool _silentUnmount;
		private entEntityID _entityID;
		private CBool _alive;
		private CBool _occupiedByNeutral;

		[Ordinal(0)] 
		[RED("silentUnmount")] 
		public CBool SilentUnmount
		{
			get => GetProperty(ref _silentUnmount);
			set => SetProperty(ref _silentUnmount, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(3)] 
		[RED("occupiedByNeutral")] 
		public CBool OccupiedByNeutral
		{
			get => GetProperty(ref _occupiedByNeutral);
			set => SetProperty(ref _occupiedByNeutral, value);
		}
	}
}
