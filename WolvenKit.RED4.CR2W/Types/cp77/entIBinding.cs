using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIBinding : ISerializable
	{
		private CBool _enabled;
		private entTagMask _enableMask;
		private CName _bindName;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enableMask")] 
		public entTagMask EnableMask
		{
			get
			{
				if (_enableMask == null)
				{
					_enableMask = (entTagMask) CR2WTypeManager.Create("entTagMask", "enableMask", cr2w, this);
				}
				return _enableMask;
			}
			set
			{
				if (_enableMask == value)
				{
					return;
				}
				_enableMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bindName")] 
		public CName BindName
		{
			get
			{
				if (_bindName == null)
				{
					_bindName = (CName) CR2WTypeManager.Create("CName", "bindName", cr2w, this);
				}
				return _bindName;
			}
			set
			{
				if (_bindName == value)
				{
					return;
				}
				_bindName = value;
				PropertySet(this);
			}
		}

		public entIBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
