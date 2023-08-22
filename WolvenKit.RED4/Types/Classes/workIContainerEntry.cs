using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class workIContainerEntry : workIEntry
	{
		[Ordinal(2)] 
		[RED("list")] 
		public CArray<CHandle<workIEntry>> List
		{
			get => GetPropertyValue<CArray<CHandle<workIEntry>>>();
			set => SetPropertyValue<CArray<CHandle<workIEntry>>>(value);
		}

		[Ordinal(3)] 
		[RED("idleAnim")] 
		public CName IdleAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workIContainerEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
