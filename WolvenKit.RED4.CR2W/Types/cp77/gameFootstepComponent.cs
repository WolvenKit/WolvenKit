using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFootstepComponent : entIComponent
	{
		private TweakDBID _tweakDBID;
		private CName _leftFootSlot;
		private CName _rightFootSlot;

		[Ordinal(3)] 
		[RED("tweakDBID")] 
		public TweakDBID TweakDBID
		{
			get
			{
				if (_tweakDBID == null)
				{
					_tweakDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "tweakDBID", cr2w, this);
				}
				return _tweakDBID;
			}
			set
			{
				if (_tweakDBID == value)
				{
					return;
				}
				_tweakDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("leftFootSlot")] 
		public CName LeftFootSlot
		{
			get
			{
				if (_leftFootSlot == null)
				{
					_leftFootSlot = (CName) CR2WTypeManager.Create("CName", "leftFootSlot", cr2w, this);
				}
				return _leftFootSlot;
			}
			set
			{
				if (_leftFootSlot == value)
				{
					return;
				}
				_leftFootSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rightFootSlot")] 
		public CName RightFootSlot
		{
			get
			{
				if (_rightFootSlot == null)
				{
					_rightFootSlot = (CName) CR2WTypeManager.Create("CName", "rightFootSlot", cr2w, this);
				}
				return _rightFootSlot;
			}
			set
			{
				if (_rightFootSlot == value)
				{
					return;
				}
				_rightFootSlot = value;
				PropertySet(this);
			}
		}

		public gameFootstepComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
