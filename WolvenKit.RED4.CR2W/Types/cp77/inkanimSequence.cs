using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSequence : IScriptable
	{
		private CName _name;
		private CArray<CHandle<inkanimDefinition>> _definitions;
		private CArray<CHandle<inkanimSequenceTargetInfo>> _targets;

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
		[RED("definitions")] 
		public CArray<CHandle<inkanimDefinition>> Definitions
		{
			get
			{
				if (_definitions == null)
				{
					_definitions = (CArray<CHandle<inkanimDefinition>>) CR2WTypeManager.Create("array:handle:inkanimDefinition", "definitions", cr2w, this);
				}
				return _definitions;
			}
			set
			{
				if (_definitions == value)
				{
					return;
				}
				_definitions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<CHandle<inkanimSequenceTargetInfo>> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<CHandle<inkanimSequenceTargetInfo>>) CR2WTypeManager.Create("array:handle:inkanimSequenceTargetInfo", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		public inkanimSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
