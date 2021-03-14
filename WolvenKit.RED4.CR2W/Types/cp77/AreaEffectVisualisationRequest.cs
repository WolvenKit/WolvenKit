using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEffectVisualisationRequest : redEvent
	{
		private CName _areaEffectID;
		private CBool _show;

		[Ordinal(0)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get
			{
				if (_areaEffectID == null)
				{
					_areaEffectID = (CName) CR2WTypeManager.Create("CName", "areaEffectID", cr2w, this);
				}
				return _areaEffectID;
			}
			set
			{
				if (_areaEffectID == value)
				{
					return;
				}
				_areaEffectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get
			{
				if (_show == null)
				{
					_show = (CBool) CR2WTypeManager.Create("Bool", "show", cr2w, this);
				}
				return _show;
			}
			set
			{
				if (_show == value)
				{
					return;
				}
				_show = value;
				PropertySet(this);
			}
		}

		public AreaEffectVisualisationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
