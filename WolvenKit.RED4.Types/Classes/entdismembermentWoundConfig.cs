using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entdismembermentWoundConfig : ISerializable
	{
		private CName _woundName;
		private CEnum<entdismembermentResourceSetE> _resourceSet;

		[Ordinal(0)] 
		[RED("WoundName")] 
		public CName WoundName
		{
			get => GetProperty(ref _woundName);
			set => SetProperty(ref _woundName, value);
		}

		[Ordinal(1)] 
		[RED("ResourceSet")] 
		public CEnum<entdismembermentResourceSetE> ResourceSet
		{
			get => GetProperty(ref _resourceSet);
			set => SetProperty(ref _resourceSet, value);
		}
	}
}
