#include "MainWidget.h"

MainWidget::MainWidget(QWidget *parent) : QWidget(parent) {
    testLabel = new QLabel("Hello");
    vbox1 = new QVBoxLayout();
    vbox1->addWidget(testLabel);
    hbox1 = new QHBoxLayout();
    hbox1->addLayout(vbox1);
    setLayout(hbox1);
}

MainWidget::~MainWidget() = default;