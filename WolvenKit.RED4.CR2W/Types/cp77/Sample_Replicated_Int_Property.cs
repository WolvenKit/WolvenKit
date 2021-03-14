using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Int_Property : CVariable
	{
		private CInt32 _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CInt32 Property
		{
			get
			{
				if (_property == null)
				{
					_property = (CInt32) CR2WTypeManager.Create("Int32", "property", cr2w, this);
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

		public Sample_Replicated_Int_Property(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
