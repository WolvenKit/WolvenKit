using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeatureEntry_ : CVariable
	{
		private CName _name;
		private CName _className;
		private CBool _forceAllocate;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("forceAllocate")] 
		public CBool ForceAllocate
		{
			get
			{
				if (_forceAllocate == null)
				{
					_forceAllocate = (CBool) CR2WTypeManager.Create("Bool", "forceAllocate", cr2w, this);
				}
				return _forceAllocate;
			}
			set
			{
				if (_forceAllocate == value)
				{
					return;
				}
				_forceAllocate = value;
				PropertySet(this);
			}
		}

		public animAnimFeatureEntry_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
