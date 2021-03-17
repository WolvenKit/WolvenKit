using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInt32ValueWrapper : CVariable
	{
		private CHandle<questIInt32ValueProvider> _valueProvider;

		[Ordinal(0)] 
		[RED("valueProvider")] 
		public CHandle<questIInt32ValueProvider> ValueProvider
		{
			get => GetProperty(ref _valueProvider);
			set => SetProperty(ref _valueProvider, value);
		}

		public questInt32ValueWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
