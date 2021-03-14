using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPropertyBinding : CVariable
	{
		private CName _propertyName;
		private CName _stylePath;

		[Ordinal(0)] 
		[RED("propertyName")] 
		public CName PropertyName
		{
			get
			{
				if (_propertyName == null)
				{
					_propertyName = (CName) CR2WTypeManager.Create("CName", "propertyName", cr2w, this);
				}
				return _propertyName;
			}
			set
			{
				if (_propertyName == value)
				{
					return;
				}
				_propertyName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stylePath")] 
		public CName StylePath
		{
			get
			{
				if (_stylePath == null)
				{
					_stylePath = (CName) CR2WTypeManager.Create("CName", "stylePath", cr2w, this);
				}
				return _stylePath;
			}
			set
			{
				if (_stylePath == value)
				{
					return;
				}
				_stylePath = value;
				PropertySet(this);
			}
		}

		public inkPropertyBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
