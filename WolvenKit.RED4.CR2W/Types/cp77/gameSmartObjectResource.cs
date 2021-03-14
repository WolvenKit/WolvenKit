using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectResource : CResource
	{
		private CArray<gameSmartObjectGate> _entryPoints;
		private CArray<gameSmartObjectGate> _exitPoints;
		private CArray<gameBodyTypeAnimationDefinition> _bodyTypes;
		private CArray<gameSmartObjectGate> _loopAnimations;
		private CEnum<gameSmartObjectType> _type;

		[Ordinal(1)] 
		[RED("entryPoints")] 
		public CArray<gameSmartObjectGate> EntryPoints
		{
			get
			{
				if (_entryPoints == null)
				{
					_entryPoints = (CArray<gameSmartObjectGate>) CR2WTypeManager.Create("array:gameSmartObjectGate", "entryPoints", cr2w, this);
				}
				return _entryPoints;
			}
			set
			{
				if (_entryPoints == value)
				{
					return;
				}
				_entryPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exitPoints")] 
		public CArray<gameSmartObjectGate> ExitPoints
		{
			get
			{
				if (_exitPoints == null)
				{
					_exitPoints = (CArray<gameSmartObjectGate>) CR2WTypeManager.Create("array:gameSmartObjectGate", "exitPoints", cr2w, this);
				}
				return _exitPoints;
			}
			set
			{
				if (_exitPoints == value)
				{
					return;
				}
				_exitPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bodyTypes")] 
		public CArray<gameBodyTypeAnimationDefinition> BodyTypes
		{
			get
			{
				if (_bodyTypes == null)
				{
					_bodyTypes = (CArray<gameBodyTypeAnimationDefinition>) CR2WTypeManager.Create("array:gameBodyTypeAnimationDefinition", "bodyTypes", cr2w, this);
				}
				return _bodyTypes;
			}
			set
			{
				if (_bodyTypes == value)
				{
					return;
				}
				_bodyTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("loopAnimations")] 
		public CArray<gameSmartObjectGate> LoopAnimations
		{
			get
			{
				if (_loopAnimations == null)
				{
					_loopAnimations = (CArray<gameSmartObjectGate>) CR2WTypeManager.Create("array:gameSmartObjectGate", "loopAnimations", cr2w, this);
				}
				return _loopAnimations;
			}
			set
			{
				if (_loopAnimations == value)
				{
					return;
				}
				_loopAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<gameSmartObjectType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameSmartObjectType>) CR2WTypeManager.Create("gameSmartObjectType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
