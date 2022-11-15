#include "MainWindow.h"

MainWindow::MainWindow(QMainWindow *parent) : QMainWindow(parent) {
    mainWidget = new MainWidget();
    setCentralWidget(mainWidget);
}

MainWindow::~MainWindow() = default;
