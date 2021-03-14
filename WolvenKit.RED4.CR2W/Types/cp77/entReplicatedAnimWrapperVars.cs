using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedAnimWrapperVars : CVariable
	{
		private netTime _serverReplicatedTime;
		private CArray<entReplicatedVariableValue> _data;

		[Ordinal(0)] 
		[RED("serverReplicatedTime")] 
		public netTime ServerReplicatedTime
		{
			get
			{
				if (_serverReplicatedTime == null)
				{
					_serverReplicatedTime = (netTime) CR2WTypeManager.Create("netTime", "serverReplicatedTime", cr2w, this);
				}
				return _serverReplicatedTime;
			}
			set
			{
				if (_serverReplicatedTime == value)
				{
					return;
				}
				_serverReplicatedTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CArray<entReplicatedVariableValue> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<entReplicatedVariableValue>) CR2WTypeManager.Create("array:entReplicatedVariableValue", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public entReplicatedAnimWrapperVars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
