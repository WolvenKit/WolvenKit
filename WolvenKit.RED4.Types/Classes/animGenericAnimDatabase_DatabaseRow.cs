using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animGenericAnimDatabase_DatabaseRow : RedBaseClass
	{
		private CArray<CInt32> _inputValues;
		private animGenericAnimDatabase_AnimationData _animationData;

		[Ordinal(0)] 
		[RED("inputValues")] 
		public CArray<CInt32> InputValues
		{
			get => GetProperty(ref _inputValues);
			set => SetProperty(ref _inputValues, value);
		}

		[Ordinal(1)] 
		[RED("animationData")] 
		public animGenericAnimDatabase_AnimationData AnimationData
		{
			get => GetProperty(ref _animationData);
			set => SetProperty(ref _animationData, value);
		}
	}
}
