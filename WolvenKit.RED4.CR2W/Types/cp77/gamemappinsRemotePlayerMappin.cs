using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsRemotePlayerMappin : gamemappinsRuntimeMappin
	{
		private CBool _hasMissionData;
		private CInt32 _vitals;

		[Ordinal(0)] 
		[RED("hasMissionData")] 
		public CBool HasMissionData
		{
			get
			{
				if (_hasMissionData == null)
				{
					_hasMissionData = (CBool) CR2WTypeManager.Create("Bool", "hasMissionData", cr2w, this);
				}
				return _hasMissionData;
			}
			set
			{
				if (_hasMissionData == value)
				{
					return;
				}
				_hasMissionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vitals")] 
		public CInt32 Vitals
		{
			get
			{
				if (_vitals == null)
				{
					_vitals = (CInt32) CR2WTypeManager.Create("Int32", "vitals", cr2w, this);
				}
				return _vitals;
			}
			set
			{
				if (_vitals == value)
				{
					return;
				}
				_vitals = value;
				PropertySet(this);
			}
		}

		public gamemappinsRemotePlayerMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
