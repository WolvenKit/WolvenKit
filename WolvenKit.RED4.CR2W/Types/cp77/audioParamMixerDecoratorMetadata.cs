using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioParamMixerDecoratorMetadata : audioEmitterMetadata
	{
		private CArray<audioMixParamDescription> _inParams;
		private CName _outputName;
		private CEnum<audioMixParamsAction> _operation;
		private CBool _globalOutput;

		[Ordinal(1)] 
		[RED("inParams")] 
		public CArray<audioMixParamDescription> InParams
		{
			get
			{
				if (_inParams == null)
				{
					_inParams = (CArray<audioMixParamDescription>) CR2WTypeManager.Create("array:audioMixParamDescription", "inParams", cr2w, this);
				}
				return _inParams;
			}
			set
			{
				if (_inParams == value)
				{
					return;
				}
				_inParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outputName")] 
		public CName OutputName
		{
			get
			{
				if (_outputName == null)
				{
					_outputName = (CName) CR2WTypeManager.Create("CName", "outputName", cr2w, this);
				}
				return _outputName;
			}
			set
			{
				if (_outputName == value)
				{
					return;
				}
				_outputName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<audioMixParamsAction> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CEnum<audioMixParamsAction>) CR2WTypeManager.Create("audioMixParamsAction", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("globalOutput")] 
		public CBool GlobalOutput
		{
			get
			{
				if (_globalOutput == null)
				{
					_globalOutput = (CBool) CR2WTypeManager.Create("Bool", "globalOutput", cr2w, this);
				}
				return _globalOutput;
			}
			set
			{
				if (_globalOutput == value)
				{
					return;
				}
				_globalOutput = value;
				PropertySet(this);
			}
		}

		public audioParamMixerDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
