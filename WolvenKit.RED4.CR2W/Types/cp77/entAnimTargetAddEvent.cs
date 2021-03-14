using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimTargetAddEvent : redEvent
	{
		private CHandle<entIPositionProvider> _targetPositionProvider;
		private CName _bodyPart;

		[Ordinal(0)] 
		[RED("targetPositionProvider")] 
		public CHandle<entIPositionProvider> TargetPositionProvider
		{
			get
			{
				if (_targetPositionProvider == null)
				{
					_targetPositionProvider = (CHandle<entIPositionProvider>) CR2WTypeManager.Create("handle:entIPositionProvider", "targetPositionProvider", cr2w, this);
				}
				return _targetPositionProvider;
			}
			set
			{
				if (_targetPositionProvider == value)
				{
					return;
				}
				_targetPositionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CName) CR2WTypeManager.Create("CName", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		public entAnimTargetAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
