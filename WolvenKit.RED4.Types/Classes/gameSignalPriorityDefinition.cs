using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSignalPriorityDefinition : ISerializable
	{
		private CUInt16 _defaultPriority;

		[Ordinal(0)] 
		[RED("defaultPriority")] 
		public CUInt16 DefaultPriority
		{
			get => GetProperty(ref _defaultPriority);
			set => SetProperty(ref _defaultPriority, value);
		}
	}
}
