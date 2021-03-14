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
			get
			{
				if (_valueProvider == null)
				{
					_valueProvider = (CHandle<questIInt32ValueProvider>) CR2WTypeManager.Create("handle:questIInt32ValueProvider", "valueProvider", cr2w, this);
				}
				return _valueProvider;
			}
			set
			{
				if (_valueProvider == value)
				{
					return;
				}
				_valueProvider = value;
				PropertySet(this);
			}
		}

		public questInt32ValueWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
