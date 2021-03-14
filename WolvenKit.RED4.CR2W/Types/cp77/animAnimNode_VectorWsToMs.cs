using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorWsToMs : animAnimNode_VectorValue
	{
		private CEnum<animEVectorWsToMsType> _type;
		private animVectorLink _vectorWs;

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<animEVectorWsToMsType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<animEVectorWsToMsType>) CR2WTypeManager.Create("animEVectorWsToMsType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("vectorWs")] 
		public animVectorLink VectorWs
		{
			get
			{
				if (_vectorWs == null)
				{
					_vectorWs = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "vectorWs", cr2w, this);
				}
				return _vectorWs;
			}
			set
			{
				if (_vectorWs == value)
				{
					return;
				}
				_vectorWs = value;
				PropertySet(this);
			}
		}

		public animAnimNode_VectorWsToMs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
