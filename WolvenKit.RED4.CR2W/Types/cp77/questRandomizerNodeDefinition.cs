using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRandomizerNodeDefinition : questDisableableNodeDefinition
	{
		private CEnum<questRandomizerMode> _mode;
		private CArray<CUInt8> _outputWeights;

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<questRandomizerMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<questRandomizerMode>) CR2WTypeManager.Create("questRandomizerMode", "mode", cr2w, this);
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
		[RED("outputWeights")] 
		public CArray<CUInt8> OutputWeights
		{
			get
			{
				if (_outputWeights == null)
				{
					_outputWeights = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "outputWeights", cr2w, this);
				}
				return _outputWeights;
			}
			set
			{
				if (_outputWeights == value)
				{
					return;
				}
				_outputWeights = value;
				PropertySet(this);
			}
		}

		public questRandomizerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
