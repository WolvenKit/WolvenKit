using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNodeStatusDebuggerCommand : AIbehaviorIDebuggerCommand
	{
		private CUInt32 _behaviorResourceHash;
		private CUInt32 _generation;
		private CArray<AIbehaviorNodeStatusDebuggerCommandEntry> _entries;

		[Ordinal(0)] 
		[RED("behaviorResourceHash")] 
		public CUInt32 BehaviorResourceHash
		{
			get
			{
				if (_behaviorResourceHash == null)
				{
					_behaviorResourceHash = (CUInt32) CR2WTypeManager.Create("Uint32", "behaviorResourceHash", cr2w, this);
				}
				return _behaviorResourceHash;
			}
			set
			{
				if (_behaviorResourceHash == value)
				{
					return;
				}
				_behaviorResourceHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("generation")] 
		public CUInt32 Generation
		{
			get
			{
				if (_generation == null)
				{
					_generation = (CUInt32) CR2WTypeManager.Create("Uint32", "generation", cr2w, this);
				}
				return _generation;
			}
			set
			{
				if (_generation == value)
				{
					return;
				}
				_generation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<AIbehaviorNodeStatusDebuggerCommandEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<AIbehaviorNodeStatusDebuggerCommandEntry>) CR2WTypeManager.Create("array:AIbehaviorNodeStatusDebuggerCommandEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public AIbehaviorNodeStatusDebuggerCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
