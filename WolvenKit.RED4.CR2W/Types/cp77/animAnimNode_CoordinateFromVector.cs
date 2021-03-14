using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_CoordinateFromVector : animAnimNode_FloatValue
	{
		private CEnum<animVectorCoordinateType> _vectorCoodrinateType;
		private animVectorLink _input;

		[Ordinal(11)] 
		[RED("vectorCoodrinateType")] 
		public CEnum<animVectorCoordinateType> VectorCoodrinateType
		{
			get
			{
				if (_vectorCoodrinateType == null)
				{
					_vectorCoodrinateType = (CEnum<animVectorCoordinateType>) CR2WTypeManager.Create("animVectorCoordinateType", "vectorCoodrinateType", cr2w, this);
				}
				return _vectorCoodrinateType;
			}
			set
			{
				if (_vectorCoodrinateType == value)
				{
					return;
				}
				_vectorCoodrinateType = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("input")] 
		public animVectorLink Input
		{
			get
			{
				if (_input == null)
				{
					_input = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "input", cr2w, this);
				}
				return _input;
			}
			set
			{
				if (_input == value)
				{
					return;
				}
				_input = value;
				PropertySet(this);
			}
		}

		public animAnimNode_CoordinateFromVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
