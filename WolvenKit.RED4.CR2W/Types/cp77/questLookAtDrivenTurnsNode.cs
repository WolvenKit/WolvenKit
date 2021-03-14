using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLookAtDrivenTurnsNode : questSignalStoppingNodeDefinition
	{
		private CEnum<questLookAtDrivenTurnsMode> _mode;
		private gameEntityReference _puppetRef;
		private CBool _canLookAtDrivenTurnsInterruptGesture;

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<questLookAtDrivenTurnsMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<questLookAtDrivenTurnsMode>) CR2WTypeManager.Create("questLookAtDrivenTurnsMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("canLookAtDrivenTurnsInterruptGesture")] 
		public CBool CanLookAtDrivenTurnsInterruptGesture
		{
			get
			{
				if (_canLookAtDrivenTurnsInterruptGesture == null)
				{
					_canLookAtDrivenTurnsInterruptGesture = (CBool) CR2WTypeManager.Create("Bool", "canLookAtDrivenTurnsInterruptGesture", cr2w, this);
				}
				return _canLookAtDrivenTurnsInterruptGesture;
			}
			set
			{
				if (_canLookAtDrivenTurnsInterruptGesture == value)
				{
					return;
				}
				_canLookAtDrivenTurnsInterruptGesture = value;
				PropertySet(this);
			}
		}

		public questLookAtDrivenTurnsNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
