using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneTime : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stu")] 
		public CUInt32 Stu
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnSceneTime()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
