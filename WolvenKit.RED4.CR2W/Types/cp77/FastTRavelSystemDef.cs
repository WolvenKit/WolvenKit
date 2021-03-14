using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTRavelSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _destinationPoint;
		private gamebbScriptID_Variant _startingPoint;
		private gamebbScriptID_Bool _fastTravelLoadingScreenFinished;

		[Ordinal(0)] 
		[RED("DestinationPoint")] 
		public gamebbScriptID_Variant DestinationPoint
		{
			get
			{
				if (_destinationPoint == null)
				{
					_destinationPoint = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DestinationPoint", cr2w, this);
				}
				return _destinationPoint;
			}
			set
			{
				if (_destinationPoint == value)
				{
					return;
				}
				_destinationPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("StartingPoint")] 
		public gamebbScriptID_Variant StartingPoint
		{
			get
			{
				if (_startingPoint == null)
				{
					_startingPoint = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "StartingPoint", cr2w, this);
				}
				return _startingPoint;
			}
			set
			{
				if (_startingPoint == value)
				{
					return;
				}
				_startingPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("FastTravelLoadingScreenFinished")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenFinished
		{
			get
			{
				if (_fastTravelLoadingScreenFinished == null)
				{
					_fastTravelLoadingScreenFinished = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "FastTravelLoadingScreenFinished", cr2w, this);
				}
				return _fastTravelLoadingScreenFinished;
			}
			set
			{
				if (_fastTravelLoadingScreenFinished == value)
				{
					return;
				}
				_fastTravelLoadingScreenFinished = value;
				PropertySet(this);
			}
		}

		public FastTRavelSystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
