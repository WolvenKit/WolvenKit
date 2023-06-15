// @version 1.0

import * as Logger from 'Logger.wscript';

const settings = {
	"Common": {},
	"MorphTarget": {
		"Binary":true
	},
	"Mlmask": {
		"ImageFormat": "png",      // dds, tga, bmp, jpg, png, tiff
		"AsList":true
	},
	"Xbm": {
		"ImageType": "png",
		"Flip":false
	},
	"Mesh": {
		"MeshExporter": "REDmod",  // Default, Experimental, REDmod
		"ExportType": "MeshOnly",  // MeshOnly, WithRig, Multimesh
		"LodFilter": true,
		"Binary": true,
		"WithMaterials": true,
		"ImageType": "png"
	},
	"Animation": {
		"Binary": true,
		"incRootMotion": false
	},
	"Wem": {
		"ExportType": "Mp3"        // Wav, Mp3
	},
	"Opus": {
		"UseMod": false
	},
	"Entity": {},
	"InkAtlas": {},
	"Fnt": {}
};

const files = [
	[ "base\\characters\\garment\\citizen_formal\\torso\\t1_072_shirt__netwatch\\t1_072_ma_shirt__netwatch_dangle.mesh", settings ],
	[ "base\\environment\\architecture\\common\\shop\\shop_vending_machine_c_v2_l600_h400_a.mesh" ],
	"engine\\ink\\util\\ad_widget_component_capture.ent"
];

for (let obj of files) {
	if (Array.isArray(obj)) {
		wkit.Extract(obj[0]);
	} else {
		wkit.Extract(obj);
	}
}

const defaultSettings = null; // export settings to apply if a file entry doesn't contains any, null for default
wkit.ExportFiles(files, defaultSettings);