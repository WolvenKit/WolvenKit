using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Double_Property : CVariable
	{
		private CDouble _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CDouble Property
		{
			get
			{
				if (_property == null)
				{
					_property = (CDouble) CR2WTypeManager.Create("Double", "property", cr2w, this);
				}
				return _property;
			}
			set
			{
				if (_property == value)
				{
					return;
				}
				_property = value;
				PropertySet(this);
			}
		}

		public Sample_Replicated_Double_Property(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
