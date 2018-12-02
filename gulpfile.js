const gulp = require('gulp');
const concat = require('gulp-concat');

const vendorStyles = [
    "node_modules/bootstrap/dist/css/bootstrap.min.css"
];
const vendorScripts = [
    "node_modules/jquery/dist/jquery.min.js",
    "node_modules/popper.js/dist/umd/popper.min.js",
    "node_modules/bootstrap/dist/js/bootstrap.min.js",
];

function build_vendor_css(cb) {
    return gulp.src(vendorStyles)
        .pipe(concat('vendor.min.css'))
        .pipe(gulp.dest('wwwroot'));
    cb();
}
function build_vendor_js(cb) {
    return gulp.src(vendorScripts)
        .pipe(concat('vendor.min.js'))
        .pipe(gulp.dest('wwwroot'));
    cb();
}

exports.default = gulp.series(build_vendor_css, build_vendor_js)