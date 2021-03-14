using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForcedVisibilityInAnimSystemData : IScriptable
	{
		private CName _sourceName;
		private gameDelayID _delayID;
		private CBool _forcedVisibleOnlyInFrustum;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get
			{
				if (_sourceName == null)
				{
					_sourceName = (CName) CR2WTypeManager.Create("CName", "sourceName", cr2w, this);
				}
				return _sourceName;
			}
			set
			{
				if (_sourceName == value)
				{
					return;
				}
				_sourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get
			{
				if (_delayID == null)
				{
					_delayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayID", cr2w, this);
				}
				return _delayID;
			}
			set
			{
				if (_delayID == value)
				{
					return;
				}
				_delayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forcedVisibleOnlyInFrustum")] 
		public CBool ForcedVisibleOnlyInFrustum
		{
			get
			{
				if (_forcedVisibleOnlyInFrustum == null)
				{
					_forcedVisibleOnlyInFrustum = (CBool) CR2WTypeManager.Create("Bool", "forcedVisibleOnlyInFrustum", cr2w, this);
				}
				return _forcedVisibleOnlyInFrustum;
			}
			set
			{
				if (_forcedVisibleOnlyInFrustum == value)
				{
					return;
				}
				_forcedVisibleOnlyInFrustum = value;
				PropertySet(this);
			}
		}

		public ForcedVisibilityInAnimSystemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
