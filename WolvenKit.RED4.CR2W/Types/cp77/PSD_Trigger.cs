using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSD_Trigger : gameObject
	{
		private NodeRef _ref;
		private CName _className;

		[Ordinal(40)] 
		[RED("ref")] 
		public NodeRef Ref
		{
			get
			{
				if (_ref == null)
				{
					_ref = (NodeRef) CR2WTypeManager.Create("NodeRef", "ref", cr2w, this);
				}
				return _ref;
			}
			set
			{
				if (_ref == value)
				{
					return;
				}
				_ref = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		public PSD_Trigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
