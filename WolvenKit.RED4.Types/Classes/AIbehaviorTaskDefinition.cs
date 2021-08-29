using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTaskDefinition : ISerializable
	{
		private CBool _ignoreTaskCompletion;

		[Ordinal(0)] 
		[RED("ignoreTaskCompletion")] 
		public CBool IgnoreTaskCompletion
		{
			get => GetProperty(ref _ignoreTaskCompletion);
			set => SetProperty(ref _ignoreTaskCompletion, value);
		}
	}
}
