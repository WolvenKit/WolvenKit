using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorParameterizedBehavior : ISerializable
	{
		private rRef<AIbehaviorResource> _treeDefinition;
		private CArray<AIArgumentOverrideWrapper> _argumentsOverrides;

		[Ordinal(0)] 
		[RED("treeDefinition")] 
		public rRef<AIbehaviorResource> TreeDefinition
		{
			get
			{
				if (_treeDefinition == null)
				{
					_treeDefinition = (rRef<AIbehaviorResource>) CR2WTypeManager.Create("rRef:AIbehaviorResource", "treeDefinition", cr2w, this);
				}
				return _treeDefinition;
			}
			set
			{
				if (_treeDefinition == value)
				{
					return;
				}
				_treeDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("argumentsOverrides")] 
		public CArray<AIArgumentOverrideWrapper> ArgumentsOverrides
		{
			get
			{
				if (_argumentsOverrides == null)
				{
					_argumentsOverrides = (CArray<AIArgumentOverrideWrapper>) CR2WTypeManager.Create("array:AIArgumentOverrideWrapper", "argumentsOverrides", cr2w, this);
				}
				return _argumentsOverrides;
			}
			set
			{
				if (_argumentsOverrides == value)
				{
					return;
				}
				_argumentsOverrides = value;
				PropertySet(this);
			}
		}

		public AIbehaviorParameterizedBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
