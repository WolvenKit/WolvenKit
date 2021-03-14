using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogicalBaseNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CUInt32 _inputSocketCount;
		private CUInt32 _outputSocketCount;

		[Ordinal(2)] 
		[RED("inputSocketCount")] 
		public CUInt32 InputSocketCount
		{
			get
			{
				if (_inputSocketCount == null)
				{
					_inputSocketCount = (CUInt32) CR2WTypeManager.Create("Uint32", "inputSocketCount", cr2w, this);
				}
				return _inputSocketCount;
			}
			set
			{
				if (_inputSocketCount == value)
				{
					return;
				}
				_inputSocketCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outputSocketCount")] 
		public CUInt32 OutputSocketCount
		{
			get
			{
				if (_outputSocketCount == null)
				{
					_outputSocketCount = (CUInt32) CR2WTypeManager.Create("Uint32", "outputSocketCount", cr2w, this);
				}
				return _outputSocketCount;
			}
			set
			{
				if (_outputSocketCount == value)
				{
					return;
				}
				_outputSocketCount = value;
				PropertySet(this);
			}
		}

		public questLogicalBaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
