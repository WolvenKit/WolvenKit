using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChestPress : InteractiveDevice
	{
		private CHandle<AnimFeature_ChestPress> _animFeatureData;
		private CName _animFeatureDataName;

		[Ordinal(93)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_ChestPress> AnimFeatureData
		{
			get => GetProperty(ref _animFeatureData);
			set => SetProperty(ref _animFeatureData, value);
		}

		[Ordinal(94)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get => GetProperty(ref _animFeatureDataName);
			set => SetProperty(ref _animFeatureDataName, value);
		}

		public ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
