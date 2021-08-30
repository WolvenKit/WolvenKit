using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIArgumentVectorValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private Vector3 _defaultValue;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("defaultValue")] 
		public Vector3 DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public AIArgumentVectorValue()
		{
			_type = new() { Value = Enums.AIArgumentType.Vector };
		}
	}
}
