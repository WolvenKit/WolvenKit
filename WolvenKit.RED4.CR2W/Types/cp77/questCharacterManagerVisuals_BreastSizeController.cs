using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_BreastSizeController : questICharacterManagerVisuals_NodeSubType
	{
		private CName _bodyGroupName;
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _customizedSize;

		[Ordinal(0)] 
		[RED("bodyGroupName")] 
		public CName BodyGroupName
		{
			get
			{
				if (_bodyGroupName == null)
				{
					_bodyGroupName = (CName) CR2WTypeManager.Create("CName", "bodyGroupName", cr2w, this);
				}
				return _bodyGroupName;
			}
			set
			{
				if (_bodyGroupName == value)
				{
					return;
				}
				_bodyGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("customizedSize")] 
		public CBool CustomizedSize
		{
			get
			{
				if (_customizedSize == null)
				{
					_customizedSize = (CBool) CR2WTypeManager.Create("Bool", "customizedSize", cr2w, this);
				}
				return _customizedSize;
			}
			set
			{
				if (_customizedSize == value)
				{
					return;
				}
				_customizedSize = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerVisuals_BreastSizeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
