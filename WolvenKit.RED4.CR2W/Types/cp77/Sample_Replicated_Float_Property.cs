using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Float_Property : CVariable
	{
		private CFloat _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CFloat Property
		{
			get
			{
				if (_property == null)
				{
					_property = (CFloat) CR2WTypeManager.Create("Float", "property", cr2w, this);
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

		public Sample_Replicated_Float_Property(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
