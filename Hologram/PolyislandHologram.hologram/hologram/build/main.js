window.__assets={"2RUnO1Yi99P_9zbqSChdKvN_obj":"2RUnO1Yi99P_9zbqSChdKvN_obj/SunshinePalmTree.obj","2oA770SsWii_5JYR_gBc26__obj":"2oA770SsWii_5JYR_gBc26__obj/1302 Sump Pump.obj","Cross":"Cross.png","IDEE4":"IDEE4.png","Labyrinth1":"Labyrinth1.5.dae","Radio":"Radio/WalkieTalkie.obj","Sky":"Sky.jpg","ipvryk":"ipvryk/model-triangulated.obj","nwcfcj":"nwcfcj/model-triangulated.obj","Skywithclouds":"Skywithclouds.jpg"};(function(scope) {Hologram.effects.bloom = null;Hologram.scene.fog = null;var __zxzgnpp7q = new Sky({color:"#d9f5ff"});var __oiwibj3ca = new Model({position:"-6.028 -4.158 -3.049",rotation:"-3 -0.19 0",scale:"130 130 130",src:"ipvryk"});var __0l1g51flh = new Model({position:"13.639 1.778 5.683",rotation:"180 37.34 -0.18",scale:"0.1 0.1 0.1",src:"2oA770SsWii_5JYR_gBc26__obj"});var __suwrsnb7m = new Model({position:"19.612 0.113 -1.184",rotation:"90 37.34 124.49",scale:"0.1 0.1 0.1",src:"2oA770SsWii_5JYR_gBc26__obj"});var __0vqwbbd64 = new Model({position:"1.187 -3.417 5.834",scale:"0.3 0.3 0.3",shadow:false,src:"Labyrinth1"});var __vqom8n6h5 = new Image({position:"1.545 -3.59 3.892",rotation:"-90 0 0",scale:"0.6 0.6 1",src:"Cross"});var __8shd53ptg = new Image({position:"2.225 -3.601 4.415",rotation:"-90 0 0",scale:"0.6 0.6 1",src:"Cross"});var __bxupqmly2 = new Image({position:"2.541 -3.568 5.471",rotation:"-90 0 0",scale:"0.6 0.6 1",src:"Cross"});var __khjr1dywg = new Image({position:"3.722 -3.608 4.32",rotation:"-90 0 0",scale:"0.6 0.6 1",src:"Cross"});var __virteqqxn = new Image({position:"4.649 -3.615 3.445",rotation:"-90 0 0",scale:"0.44 0.27 1",src:"Cross"});var __brtwim0gi = new Image({position:"5.913 -3.601 1.525",rotation:"-90 0 0",scale:"0.42 0.47 1",src:"Cross"});var __0b3lhis7g = new Image({position:"5.48 -3.605 1.424",rotation:"-90 0 0",scale:"0.6 0.56 1",src:"Cross"});var __d9syhfhsa = new Image({position:"3.45 -3.579 2.48",rotation:"-90 0 0",scale:"0.6 0.6 1",src:"Cross"});var __u2r279o6p = new Image({position:"5.313 -3.627 4.672",rotation:"-90 0 0",scale:"0.53 0.4 1",src:"Cross"});var __eouodeegt = new Image({position:"2.3 -3.486 1.615",rotation:"90 0 14.25",scale:"0.43 0.38 1",src:"Cross"});var __362yxpuyb = new Model({position:"-0.876 -3.044 -0.057",rotation:"-69.08 -0.8 0.45",scale:"0.2 0.2 0.2",src:"Radio"});var __u408lqdzr = new Image({position:"-38.201 3.344 -44.89",rotation:"0 54.19 -2.15",scale:"30 30 1",src:"Skywithclouds"});Object.assign(scope,{});})(window);/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId])
/******/ 			return installedModules[moduleId].exports;
/******/
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			exports: {},
/******/ 			id: moduleId,
/******/ 			loaded: false
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ (function(module, exports) {

	var myLight;
	
	myLight = new Light({
	  color: "#AFA",
	  intensity: 1.9,
	  position: "-1 1 0"
	});
	
	myLight = new Light({
	  type: Light.point,
	  color: "#cadd4b",
	  intensity: 0.2,
	  position: "-2 5 10",
	  castShadow: true
	});


/***/ })
/******/ ]);
//# sourceMappingURL=main.js.map?hash=54a7a17158050dfa4eeb