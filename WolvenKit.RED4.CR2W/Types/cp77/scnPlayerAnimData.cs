using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayerAnimData : CVariable
	{
		private CHandle<gameSceneTierData> _tierData;
		private CBool _useZSnapping;
		private CBool _unmountBodyCarry;

		[Ordinal(0)] 
		[RED("tierData")] 
		public CHandle<gameSceneTierData> TierData
		{
			get
			{
				if (_tierData == null)
				{
					_tierData = (CHandle<gameSceneTierData>) CR2WTypeManager.Create("handle:gameSceneTierData", "tierData", cr2w, this);
				}
				return _tierData;
			}
			set
			{
				if (_tierData == value)
				{
					return;
				}
				_tierData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useZSnapping")] 
		public CBool UseZSnapping
		{
			get
			{
				if (_useZSnapping == null)
				{
					_useZSnapping = (CBool) CR2WTypeManager.Create("Bool", "useZSnapping", cr2w, this);
				}
				return _useZSnapping;
			}
			set
			{
				if (_useZSnapping == value)
				{
					return;
				}
				_useZSnapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("unmountBodyCarry")] 
		public CBool UnmountBodyCarry
		{
			get
			{
				if (_unmountBodyCarry == null)
				{
					_unmountBodyCarry = (CBool) CR2WTypeManager.Create("Bool", "unmountBodyCarry", cr2w, this);
				}
				return _unmountBodyCarry;
			}
			set
			{
				if (_unmountBodyCarry == value)
				{
					return;
				}
				_unmountBodyCarry = value;
				PropertySet(this);
			}
		}

		public scnPlayerAnimData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
