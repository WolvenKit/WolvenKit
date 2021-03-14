using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRandomizerNode : scnSceneGraphNode
	{
		private CEnum<scnRandomizerMode> _mode;
		private CUInt32 _numOutSockets;
		private CArrayFixedSize<CUInt8> _weights;

		[Ordinal(3)] 
		[RED("mode")] 
		public CEnum<scnRandomizerMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<scnRandomizerMode>) CR2WTypeManager.Create("scnRandomizerMode", "mode", cr2w, this);
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

		[Ordinal(4)] 
		[RED("numOutSockets")] 
		public CUInt32 NumOutSockets
		{
			get
			{
				if (_numOutSockets == null)
				{
					_numOutSockets = (CUInt32) CR2WTypeManager.Create("Uint32", "numOutSockets", cr2w, this);
				}
				return _numOutSockets;
			}
			set
			{
				if (_numOutSockets == value)
				{
					return;
				}
				_numOutSockets = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("weights", 32)] 
		public CArrayFixedSize<CUInt8> Weights
		{
			get
			{
				if (_weights == null)
				{
					_weights = (CArrayFixedSize<CUInt8>) CR2WTypeManager.Create("[32]Uint8", "weights", cr2w, this);
				}
				return _weights;
			}
			set
			{
				if (_weights == value)
				{
					return;
				}
				_weights = value;
				PropertySet(this);
			}
		}

		public scnRandomizerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
