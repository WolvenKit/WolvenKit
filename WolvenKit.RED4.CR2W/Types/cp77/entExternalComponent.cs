using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entExternalComponent : entIComponent
	{
		private CName _externalComponentName;

		[Ordinal(3)] 
		[RED("externalComponentName")] 
		public CName ExternalComponentName
		{
			get
			{
				if (_externalComponentName == null)
				{
					_externalComponentName = (CName) CR2WTypeManager.Create("CName", "externalComponentName", cr2w, this);
				}
				return _externalComponentName;
			}
			set
			{
				if (_externalComponentName == value)
				{
					return;
				}
				_externalComponentName = value;
				PropertySet(this);
			}
		}

		public entExternalComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
