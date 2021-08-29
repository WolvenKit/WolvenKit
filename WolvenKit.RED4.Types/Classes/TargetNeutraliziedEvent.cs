using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetNeutraliziedEvent : redEvent
	{
		private CEnum<ENeutralizeType> _type;
		private entEntityID _targetID;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<ENeutralizeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}
	}
}
