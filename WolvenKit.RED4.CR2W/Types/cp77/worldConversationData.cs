using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldConversationData : ISerializable
	{
		private raRef<scnSceneResource> _sceneFilename;
		private CHandle<questIBaseCondition> _condition;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;
		private CBool _ignoreLocalLimit;
		private CBool _ignoreGlobalLimit;

		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public raRef<scnSceneResource> SceneFilename
		{
			get
			{
				if (_sceneFilename == null)
				{
					_sceneFilename = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFilename", cr2w, this);
				}
				return _sceneFilename;
			}
			set
			{
				if (_sceneFilename == value)
				{
					return;
				}
				_sceneFilename = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get
			{
				if (_interruptionOperations == null)
				{
					_interruptionOperations = (CArray<CHandle<scnIInterruptionOperation>>) CR2WTypeManager.Create("array:handle:scnIInterruptionOperation", "interruptionOperations", cr2w, this);
				}
				return _interruptionOperations;
			}
			set
			{
				if (_interruptionOperations == value)
				{
					return;
				}
				_interruptionOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ignoreLocalLimit")] 
		public CBool IgnoreLocalLimit
		{
			get
			{
				if (_ignoreLocalLimit == null)
				{
					_ignoreLocalLimit = (CBool) CR2WTypeManager.Create("Bool", "ignoreLocalLimit", cr2w, this);
				}
				return _ignoreLocalLimit;
			}
			set
			{
				if (_ignoreLocalLimit == value)
				{
					return;
				}
				_ignoreLocalLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ignoreGlobalLimit")] 
		public CBool IgnoreGlobalLimit
		{
			get
			{
				if (_ignoreGlobalLimit == null)
				{
					_ignoreGlobalLimit = (CBool) CR2WTypeManager.Create("Bool", "ignoreGlobalLimit", cr2w, this);
				}
				return _ignoreGlobalLimit;
			}
			set
			{
				if (_ignoreGlobalLimit == value)
				{
					return;
				}
				_ignoreGlobalLimit = value;
				PropertySet(this);
			}
		}

		public worldConversationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
