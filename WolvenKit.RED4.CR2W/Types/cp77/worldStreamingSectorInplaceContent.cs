using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorInplaceContent : CResource
	{
		private CArray<rRef<CResource>> _inplaceResources;

		[Ordinal(1)] 
		[RED("inplaceResources")] 
		public CArray<rRef<CResource>> InplaceResources
		{
			get
			{
				if (_inplaceResources == null)
				{
					_inplaceResources = (CArray<rRef<CResource>>) CR2WTypeManager.Create("array:rRef:CResource", "inplaceResources", cr2w, this);
				}
				return _inplaceResources;
			}
			set
			{
				if (_inplaceResources == value)
				{
					return;
				}
				_inplaceResources = value;
				PropertySet(this);
			}
		}

		public worldStreamingSectorInplaceContent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
