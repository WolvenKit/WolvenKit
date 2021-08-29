using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioSceneVariableReadActionData : RedBaseClass
	{
		private CName _name;
		private CEnum<audioNumberComparer> _comparer;
		private CInt32 _value;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("comparer")] 
		public CEnum<audioNumberComparer> Comparer
		{
			get => GetProperty(ref _comparer);
			set => SetProperty(ref _comparer, value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
