using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redResourceReferenceScriptToken : CVariable
	{
		private raRef<CResource> _resource;

		[Ordinal(0)] 
		[RED("resource")] 
		public raRef<CResource> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "resource", cr2w, this);
				}
				return _resource;
			}
			set
			{
				if (_resource == value)
				{
					return;
				}
				_resource = value;
				PropertySet(this);
			}
		}

		public redResourceReferenceScriptToken(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
