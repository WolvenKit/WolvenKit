using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectionToEuler : animAnimNode_FloatValue
	{
		private animVectorLink _inputNode;
		private Vector4 _initialForwardVector;
		private CEnum<animEDirectionToEuler> _conversionType;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animVectorLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get
			{
				if (_initialForwardVector == null)
				{
					_initialForwardVector = (Vector4) CR2WTypeManager.Create("Vector4", "initialForwardVector", cr2w, this);
				}
				return _initialForwardVector;
			}
			set
			{
				if (_initialForwardVector == value)
				{
					return;
				}
				_initialForwardVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("conversionType")] 
		public CEnum<animEDirectionToEuler> ConversionType
		{
			get
			{
				if (_conversionType == null)
				{
					_conversionType = (CEnum<animEDirectionToEuler>) CR2WTypeManager.Create("animEDirectionToEuler", "conversionType", cr2w, this);
				}
				return _conversionType;
			}
			set
			{
				if (_conversionType == value)
				{
					return;
				}
				_conversionType = value;
				PropertySet(this);
			}
		}

		public animAnimNode_DirectionToEuler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
