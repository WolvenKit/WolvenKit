using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAIBlackboardSerializableID : RedBaseClass
	{
		private gameBlackboardSerializableID _id;

		[Ordinal(0)] 
		[RED("id")] 
		public gameBlackboardSerializableID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
